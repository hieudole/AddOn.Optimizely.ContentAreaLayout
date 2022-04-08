﻿using System.Collections.Generic;

namespace RenderingLayoutProcessor.Impl
{
    public class BootstrapRenderingContext : GridRenderingContext
    {
        public BootstrapRenderingContext(int[] itemSizes = null)
            : base(itemSizes) { }

        protected override IEnumerable<string> GetRowClasses()
        {
            return new[] { "row" };
        }

        protected override IEnumerable<string> GetColumnClasses()
        {
            var currentColumn = _itemSizes[_renderedItemsCount % _itemSizes.Length];

            _columnsRendered += currentColumn;

            return new[] { $"col-{currentColumn}" };
        }
    }
}