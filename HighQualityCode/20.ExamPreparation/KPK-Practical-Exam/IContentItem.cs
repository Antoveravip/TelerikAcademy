namespace FreeContentCatalog
{
    using System;

    public interface IContentItem : IComparable
    {
        string Title { get; set; }

        string Author { get; set; }

        Int64 Size { get; set; }

        string URL { get; set; }

        ContentItemType Type { get; set; }

        string TextRepresentation { get; set; }
    }
}