using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONT_Project_Semester2
{
    
        public sealed class UserAccess
        {
            private UserAccess() { }
            private static UserAccess instance = null;

            public static UserAccess Instance
            {
                get
                {
                    if (instance == null)
                    {
                        instance = new UserAccess();
                    }
                    return instance;
                }
            }

            public string UserType { get; set; }

            public string username { get; set; }

            public string password { get; set; }
        }
    }
