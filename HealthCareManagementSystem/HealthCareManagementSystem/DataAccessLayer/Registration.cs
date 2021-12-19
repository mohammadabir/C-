using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthCareManagementSystem.DataAccessLayer
{
    class Registration

    {
        public int RegSlNo { get; set; }
    
        public string Username { get; set; }
        public string Gender { get; set; }
       
        public string Email { get; set; }
        public string Number { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }

        internal object GetregistrationBySlNo(TextBox appointSearchtextBox1)
        {
            throw new NotImplementedException();
        }

        internal object GetRegistrationBySlNo(TextBox appointSearchtextBox1)
        {
            throw new NotImplementedException();
        }

        internal object GetRegistrationByName(TextBox appointSearchtextBox1)
        {
            throw new NotImplementedException();
        }

        internal object GetRegistrationByName(string text)
        {
            throw new NotImplementedException();
        }
    }
}
