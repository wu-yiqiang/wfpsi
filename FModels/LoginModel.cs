using PSI.Models.VModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFPSI.FModels
{
    public class LoginModel
    {
        public List<ViewUserRoleModel> URList { get; set; }
        public Login_Form Login_Form {  get; set; }
    }
}
