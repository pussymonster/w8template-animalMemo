using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media.Imaging;

namespace AnimalMemo.model
{
    class MemoTile
    {
        private bool visible;
        private bool matched;
        private MemoTileType type;

        public MemoTile(MemoTileType type)
        {
            visible = false;
            matched = false;
            this.type = type;
        }

        public bool Visible { get { return visible; } set { this.visible = value; } }
        public bool Matched { get { return matched; } set { this.matched = value; } }
        public MemoTileType Type { get { return type; } set { this.type = value; } }
        
    }
}
