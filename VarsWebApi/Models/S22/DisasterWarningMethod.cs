using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VarsWebApi.Models
{
    public class DisasterWarningMethod
    {
        public bool GovernmentProcess { get; set; }
        public bool CommunityPlan { get; set; }
        public bool ConsultingService { get; set; }
        public bool HasOther { get; set; }

        /// <summary>
        /// ระบุลักษณะการดำเนินการมาตรการเตือนภัย
        /// </summary>
        public string Other { get; set; }
    }
}
