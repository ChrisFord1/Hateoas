using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ben
{
    /// <summary>
    /// Refers to a resource that can be used to edit the link's context.
    /// </summary>
    public class EditLink : Link
    {
        public const string Relation = "edit";

        public EditLink(string href, string title = null)
            : base(Relation, href, title)
        {
        }
    }
}