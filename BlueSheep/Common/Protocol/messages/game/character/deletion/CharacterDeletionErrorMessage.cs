









// Generated on 12/11/2014 19:01:23
using System;
using System.Collections.Generic;
using System.Linq;
using BlueSheep.Common.Protocol.Types;
using BlueSheep.Common.IO;
using BlueSheep.Engine.Types;

namespace BlueSheep.Common.Protocol.Messages
{
    public class CharacterDeletionErrorMessage : Message
    {
        public new const uint ID =166;
        public override uint ProtocolID
        {
            get { return ID; }
        }
        
        public sbyte reason;
        
        public CharacterDeletionErrorMessage()
        {
        }
        
        public CharacterDeletionErrorMessage(sbyte reason)
        {
            this.reason = reason;
        }
        
        public override void Serialize(BigEndianWriter writer)
        {
            writer.WriteSByte(reason);
        }
        
        public override void Deserialize(BigEndianReader reader)
        {
            reason = reader.ReadSByte();
            if (reason < 0)
                throw new Exception("Forbidden value on reason = " + reason + ", it doesn't respect the following condition : reason < 0");
        }
        
    }
    
}