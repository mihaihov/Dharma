using Application.Contracts.Session;
using Domain.Entities.MockEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockSession
{
    public sealed class MockSession : IMockSession
    {
        private static MockSession? _session;
        public static MockSession Session 
        { 
            get 
            {
                if (_session == null) _session = new MockSession();
                return _session; 
            } 
        }

        private MockSession()
        {
            
        }

        public Task<AnsibleMachineSession> GetAnsibleMachineSession()
        {
            throw new NotImplementedException();
        }

        public Task<UserSession> GetUserSession()
        {
            throw new NotImplementedException();
        }
    }
}
