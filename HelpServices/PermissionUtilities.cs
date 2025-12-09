using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LANMIC_ComBank_Interface.Enums;

namespace LANMIC_ComBank_Interface.HelpServices
{
    public static class PermissionUtilities
    {
        // Ensure View required: if any non-view bit present, add View automatically.
        public static byte EnforceViewRequired(byte bits)
        {
            const int nonViewMask = (int)(AccessPermissions.New | AccessPermissions.Edit | AccessPermissions.Delete | AccessPermissions.Print); // 30
            if ((bits & nonViewMask) != 0 && (bits & (byte)AccessPermissions.View) == 0)
            {
                bits |= (byte)AccessPermissions.View;
            }
            return (byte)(bits & 31);
        }

        public static byte Encode(bool view, bool create, bool edit, bool del, bool print)
        {
            byte b = 0;
            if (view) b |= (byte)AccessPermissions.View;
            if (create) b |= (byte)AccessPermissions.New;
            if (edit) b |= (byte)AccessPermissions.Edit;
            if (del) b |= (byte)AccessPermissions.Delete;
            if (print) b |= (byte)AccessPermissions.Print;
            return EnforceViewRequired(b);
        }

        public static (bool View, bool New, bool Edit, bool Delete, bool Print) Decode(byte bits)
        {
            return (
                (bits & (byte)AccessPermissions.View) == (byte)AccessPermissions.View,
                (bits & (byte)AccessPermissions.New) == (byte)AccessPermissions.New,
                (bits & (byte)AccessPermissions.Edit) == (byte)AccessPermissions.Edit,
                (bits & (byte)AccessPermissions.Delete) == (byte)AccessPermissions.Delete,
                (bits & (byte)AccessPermissions.Print) == (byte)AccessPermissions.Print
            );
        }
    }
}
