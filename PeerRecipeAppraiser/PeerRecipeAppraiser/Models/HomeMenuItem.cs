using System;
using System.Collections.Generic;
using System.Text;

namespace PeerRecipeAppraiser.Models
{
    public enum MenuItemType
    {
        Browse,
        About
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
