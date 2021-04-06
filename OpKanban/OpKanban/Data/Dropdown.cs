using System;
using System.Collections.Generic;

namespace OpKanban.Data
{
    class DDLOption {
        public string Key {get;set;}
        public string Value {get;set;}
    }
    class DDL_Color
    {
        private static List<DDLOption> _l = new List<DDLOption>() {
            new DDLOption { Key="Red", Value="#E51400"},
            new DDLOption { Key="Cyan", Value="#1BA1E2"},
            new DDLOption { Key="Amber", Value="#F0A30A"},
            new DDLOption { Key="Crimson", Value="#A20025"},
            new DDLOption { Key="Emerald", Value="#008A00"},
            new DDLOption { Key="Green", Value="#60A917"},
            new DDLOption { Key="Indigo", Value="#6A00FF"},
            new DDLOption { Key="Magenta", Value="#D80073"},
            new DDLOption { Key="Mauve", Value="#76608A"},
            new DDLOption { Key="Orange", Value="#FA6800"},
            new DDLOption { Key="Pink", Value="#F472D0"},
            new DDLOption { Key="Teal", Value="#00ABA9"},
            new DDLOption { Key="Yellow", Value="#E3C800"}
        };
        public static List<DDLOption> Colors {
            get {return _l;}
        }
    }

    class DDL_Stage
    {
        private static List<DDLOption> _l = new List<DDLOption>() {
            new DDLOption { Key="Discovery", Value="Discovery"},
            new DDLOption { Key="Sizing", Value="Sizing"},
            new DDLOption { Key="Tech Validation", Value="Tech Validation"},
            new DDLOption { Key="Contract/Paper", Value="Contract/Paper"},
            new DDLOption { Key="Closed Won", Value="Closed Won"},
            new DDLOption { Key="Closed Lost", Value="Closed Lost"}
        };
        public static List<DDLOption> Stages {
            get {return _l;}
        }
    }

    class DDL_Champs
    {
        private static List<DDLOption> _l = new List<DDLOption>() {
            new DDLOption { Key="Not a target", Value="Not a target"},
            new DDLOption { Key="Target", Value="Target"},
            new DDLOption { Key="Skeptic", Value="Skeptic"},
            new DDLOption { Key="Champion", Value="Champion"},
            new DDLOption { Key="Tested Champion", Value="Tested Champion"},
            new DDLOption { Key="Coach", Value="Coach"},
            new DDLOption { Key="EB", Value="EB"},
            new DDLOption { Key="Adversary", Value="Adversary"},
            new DDLOption { Key="Blocker", Value="Blocker"}
        };
        public static List<DDLOption> Statuses {
            get {return _l;}
        }
    }
}