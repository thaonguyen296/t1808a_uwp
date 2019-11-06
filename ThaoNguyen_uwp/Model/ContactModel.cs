using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThaoNguyen_uwp.Entity;
using ThaoNguyen_uwp.Util;

namespace ThaoNguyen_uwp.Model
{
    class ContactModel
    {
        public bool Insert(Contact contact)
        {
            try
            {
                using (var stt = SQLiteUtil.GetIntances().Connection.Prepare("INSERT INTO Contact (Name, PhoneNumber) VALUES (?, ?)"))
                {
                    stt.Bind(1, contact.Name);
                    stt.Bind(2, contact.PhoneNumber);
                    stt.Step();
                    return true;
                }
            }
            catch (Exception ex)
            {
                
            }
            return false;
        }
    }
}
