﻿using AttackSurfaceAnalyzer.Types;
using System;
using System.Collections.Generic;

namespace AttackSurfaceAnalyzer.Objects
{
    public class AsaRun
    {
        public RUN_TYPE Type { get; set; }
        public string RunId { get; set; }
        public DateTime Timestamp { get; set; }
        public string Version { get; set; }
        public PLATFORM Platform { get; set; }
        public List<RESULT_TYPE> ResultTypes { get; set; }

        public AsaRun(string RunId, DateTime Timestamp, string Version, PLATFORM Platform, List<RESULT_TYPE> ResultTypes, RUN_TYPE Type)
        {
            this.RunId = RunId;
            this.Timestamp = Timestamp;
            this.Version = Version;
            this.Platform = Platform;
            this.ResultTypes = ResultTypes;
            this.Type = Type;
        }
    }
}
