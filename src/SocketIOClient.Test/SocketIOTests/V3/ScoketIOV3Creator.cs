﻿using System.Collections.Generic;

namespace SocketIOClient.Test.SocketIOTests.V3
{
    public class ScoketIOV3Creator : ISocketIOCreateable
    {
        public SocketIO Create()
        {
            return new SocketIO(Url, new SocketIOOptions
            {
                Query = new Dictionary<string, string>
                {
                    { "token", Token }
                },
                EIO = EIO
            });
        }

        public string Prefix => "V3: ";
        public string Token => "V3";
        public string Url => "http://localhost:11003";
        public int EIO => 4;
    }
}
