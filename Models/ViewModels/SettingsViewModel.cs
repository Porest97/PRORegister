using PRORegister.Models.SettingModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PRORegister.Models.ViewModels
{
    public class SettingsViewModel
    {
        public List<AssociationType> AssociationTypes { get; internal set; }

        public List<CommunicationType> CommunicationTypes { get; internal set; }

        public List<EconomicsType> EconomicsTypes { get; internal set; }

        public List<LocationType> LocationTypes { get; internal set; }

        public List<PersonRole> PersonRoles { get; internal set; }

        public List<PersonStatus> PersonStatuses { get; internal set; }

        public List<PersonType> PersonTypes { get; internal set; }


    }
}
