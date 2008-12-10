/*
 * Project copyright 2005-2008 David H. DeWolf and Justin Dearing
 * This class taken from http://blog.codebeside.org/archive/2008/08/27/counting-the-number-of-messages-in-a-message-queue-in.aspx
 * Used with permission.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */


using System;
using System.Messaging;
using System.Runtime.InteropServices;

internal static class MessageQueueExtensions
{

    [DllImport("mqrt.dll")]
    private unsafe static extern int MQMgmtGetInfo(char* computerName, char* objectName, MQMGMTPROPS* mgmtProps);

    private const byte VT_NULL = 1;
    private const byte VT_UI4 = 19;
    private const int PROPID_MGMT_QUEUE_MESSAGE_COUNT = 7;

    //size must be 16
    [StructLayout(LayoutKind.Sequential)]
    private struct MQPROPVariant
    {
        public byte vt;       //0
        public byte spacer;   //1
        public short spacer2; //2
        public int spacer3;   //4
        public uint ulVal;    //8
        public int spacer4;   //12
    }

    //size must be 16 in x86 and 28 in x64
    [StructLayout(LayoutKind.Sequential)]
    private unsafe struct MQMGMTPROPS
    {
        public uint cProp;
        public int* aPropID;
        public MQPROPVariant* aPropVar;
        public int* status;
    }

    public static uint GetCount(this MessageQueue queue)
    {
        return GetCount(queue.Path);
    }

    private static unsafe uint GetCount(string path)
    {
        MQMGMTPROPS props = new MQMGMTPROPS();
        props.cProp = 1;

        int aPropId = PROPID_MGMT_QUEUE_MESSAGE_COUNT;
        props.aPropID = &aPropId;

        MQPROPVariant aPropVar = new MQPROPVariant();
        aPropVar.vt = VT_NULL;
        props.aPropVar = &aPropVar;

        int status = 0;
        props.status = &status;

        IntPtr objectName = Marshal.StringToBSTR("queue=Direct=OS:" + path);
        try
        {
            int result = MQMgmtGetInfo(null, (char*)objectName, &props);
            if (result != 0 || *props.status != 0 || props.aPropVar->vt != VT_UI4)
            {
                return 0;
            }
            else
            {
                return props.aPropVar->ulVal;
            }
        }
        finally
        {
            Marshal.FreeBSTR(objectName);
        }
    }
}