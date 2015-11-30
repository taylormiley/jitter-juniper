using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Jitter.Models
{
    public class JitterRepository
    {
        private JitterContext _context;
        public JitterContext Context { get {return _context;}}

        public JitterRepository()
        {
            _context = new JitterContext();
        }

        public JitterRepository(JitterContext a_context)
        {
            _context = a_context;
        }

        public List<JitterUser> GetAllUsers()
        {
            var query = from users in _context.JitterUsers select users;
            return query.ToList();
        }

        public JitterUser GetUserByHandle(string handle)
        {
<<<<<<< HEAD
            // SQL: select * from JitterUsers where JitterUser.Handle = handle;
            var query = from user in _context.JitterUsers where user.Handle == handle select user;
            // We need to make sure there's exactly one user returned. hmmmm.
=======
            // SQL: select * from JitterUsers AS users where users.Handle = handle;
            var query = from user in _context.JitterUsers where user.Handle == handle select user;
            // IQueryable<JitterUser> query = from user in _context.JitterUsers where user.Handle == handle select user;
            // We need to make sure there's exactly one user returned. hmmmm.

>>>>>>> 60b003e01b2a5da429216a03ddc1f3260879bf20
            return query.SingleOrDefault();
        }

        public bool IsHandleAvailable(string handle)
        {
            bool available = false;
            try
            {
                JitterUser some_user = GetUserByHandle(handle);
                if (some_user == null)
                {
                    available = true;
                }
            }
            catch (InvalidOperationException){}
<<<<<<< HEAD
            
=======

>>>>>>> 60b003e01b2a5da429216a03ddc1f3260879bf20
            return available;
        }

        public List<JitterUser> SearchByHandle(string handle)
        {
            // SQL: select * from JitterUsers As users where users.Handle like '%handle%';
<<<<<<< HEAD
=======
            // handleblah
            // blahhandle
            // blahhandleblah
>>>>>>> 60b003e01b2a5da429216a03ddc1f3260879bf20
            var query = from user in _context.JitterUsers select user;
            List<JitterUser> found_users = query.Where(user => user.Handle.Contains(handle)).ToList();
            found_users.Sort();
            return found_users;
        }
    }
}