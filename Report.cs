using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_projekt1
{
    class Report : Equipment
    {
        private string _description;
        private ActionType _action;

        public enum ActionType
        {
            Replace,
            Repair
        }

        public Report(string description, ActionType action, int equipmentID, EquipmentType equipmentType): base(equipmentID, equipmentType)
        {
            _description = description;
            _action = action;
        }
    }
}
