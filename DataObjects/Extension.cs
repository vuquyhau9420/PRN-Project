using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary {
    public static class Extension {

        public static int AsId(this object item, int defaultId = -1) {
            if (item == null)
                return defaultId;

            int result;
            if (!int.TryParse(item.ToString(), out result))
                return defaultId;

            return result;
        }

        public static int AsInt(this object item, int defaultInt = default(int)) {
            if (item == null)
                return defaultInt;

            int result;
            if (!int.TryParse(item.ToString(), out result))
                return defaultInt;

            return result;
        }

        public static float AsFloat(this object item, float defaultFloat = default(float)) {
            if (item == null)
                return defaultFloat;

            float result;
            if (!float.TryParse(item.ToString(), out result))
                return defaultFloat;
            return result;
        }

        public static string AsString(this object item, string defaultString = default(string)) {
            if (item == null || item.Equals(System.DBNull.Value))
                return defaultString;

            return item.ToString().Trim();
        }

        public static bool AsBoolean(this object item, bool defaultBoolean = default(bool)) {
            if (item == null || item.Equals(System.DBNull.Value)) {
                return defaultBoolean;
            }
            return (bool)item;
        }

        public static DateTime AsDateTime(this object item, DateTime defaultDateTime = default(DateTime)) {
            if (item == null || item.Equals(System.DBNull.Value)) {
                return defaultDateTime;
            }
            return DateTime.Parse(item.ToString());
        }
    }
}
