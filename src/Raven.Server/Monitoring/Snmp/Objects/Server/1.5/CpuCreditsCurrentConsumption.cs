﻿using Lextm.SharpSnmpLib;

namespace Raven.Server.Monitoring.Snmp.Objects.Server
{
    public class CpuCreditsCurrentConsumption : ScalarObjectBase<Gauge32>
    {
        private readonly RavenServer.CpuCreditsState _state;

        public CpuCreditsCurrentConsumption(RavenServer.CpuCreditsState state) 
            : base(SnmpOids.Server.CpuCreditsCurrentConsumption)
        {
            _state = state;
        }

        protected override Gauge32 GetData()
        {
            return new Gauge32((int)_state.CurrentConsumption);
        }
    }
}