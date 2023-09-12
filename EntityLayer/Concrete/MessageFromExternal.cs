using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class MessageFromExternal
    {
        [Key]
        public int MessageFromExternalID { get; set; }
        public string MessageFromExternalName { get; set; }
        public string MessageFromExternalEmail { get; set; }
        public string MessageFromExternalSubject { get; set; }
        public string MessageFromExternalContent { get; set; }

    }
}
