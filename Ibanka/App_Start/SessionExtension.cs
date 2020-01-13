using Ibanka.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ibanka
{
  
        public static class SessionExtension
        {
            public static void Set(this HttpSessionStateBase session, SessionModel value)
            {
               session["user"] = value;
            }
            public static SessionModel Get(this HttpSessionStateBase session)
            {
                return session["user"] as SessionModel;
            }
        }


    }
