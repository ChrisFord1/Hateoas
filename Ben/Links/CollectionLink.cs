﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ben
{
    /// <summary>
    /// The target IRI points to a resource which represents the collection resource for the context IRI.
    /// </summary>
    public class CollectionLink : Link
    {
        public const string Relation = "collection";

        public CollectionLink(string href, string title = null)
            : base(Relation, href, title)
        {
        }
    }
}