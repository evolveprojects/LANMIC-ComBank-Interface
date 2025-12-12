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
        public static int EnforceViewRequired(int bits)
        {
            const int nonViewMask = (int)(AccessPermissions.New | AccessPermissions.Edit | AccessPermissions.Delete | AccessPermissions.Print); // 30
            if ((bits & nonViewMask) != 0 && (bits & (int)AccessPermissions.View) == 0)
            {
                bits |= (int)AccessPermissions.View;
            }
            return (int)(bits & 31);
        }

        public static int Encode(bool view, bool create, bool edit, bool del, bool print)
        {
            int b = 0;
            if (view) b |= (int)AccessPermissions.View;
            if (create) b |= (int)AccessPermissions.New;
            if (edit) b |= (int)AccessPermissions.Edit;
            if (del) b |= (int)AccessPermissions.Delete;
            if (print) b |= (int)AccessPermissions.Print;
            return EnforceViewRequired(b);
        }

        public static (bool View, bool New, bool Edit, bool Delete, bool Print) Decode(int bits)
        {
            return (
                (bits & (int)AccessPermissions.View) == (int)AccessPermissions.View,
                (bits & (int)AccessPermissions.New) == (int)AccessPermissions.New,
                (bits & (int)AccessPermissions.Edit) == (int)AccessPermissions.Edit,
                (bits & (int)AccessPermissions.Delete) == (int)AccessPermissions.Delete,
                (bits & (int)AccessPermissions.Print) == (int)AccessPermissions.Print
            );
        }
    }
}
