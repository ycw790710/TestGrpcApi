using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GrpcProtoTemplateVSIXProject.Controls
{
    internal class GetControls
    {
        public static IEnumerable<Control> RecursivelyGet(Control cur, HashSet<Type> excludedTypes = null)
        {
            if (cur == null)
                yield break;

            foreach (Control child in cur.Controls)
                foreach (var control in RecursivelyGet(child, excludedTypes))
                    if (!excludedTypes.Contains(control.GetType()))
                        yield return control;
            if (!excludedTypes.Contains(cur.GetType()))
                yield return cur;
        }
    }
}
