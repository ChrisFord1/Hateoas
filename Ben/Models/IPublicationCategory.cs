using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ben
{
    /// <summary>
    /// An interface for items that can be returned as Atom categories.
    /// </summary>
    public interface IPublicationCategory
    {
        /// <summary>
        /// Required. The name (term) of the category.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Optional.
        /// </summary>
        string Label { get; }
    }
}
