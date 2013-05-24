using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media.Imaging;

namespace AnimalMemo.model
{
    public sealed class MemoTileType
    {
        private readonly BitmapImage tileTypeImage;
        private readonly int index;

        private static readonly Dictionary<int, MemoTileType> instance = new Dictionary<int, MemoTileType>();
        
        private static readonly MemoTileType LION = new MemoTileType(0, "ms-appx:///Assets/images/lion.png");
        private static readonly MemoTileType ELEPHANT = new MemoTileType(1, "ms-appx:///Assets/images/elephant.png");
        private static readonly MemoTileType CAT = new MemoTileType(2, "ms-appx:///Assets/images/cat.png");
        private static readonly MemoTileType DOG = new MemoTileType(3, "ms-appx:///Assets/images/dog.png");
        private static readonly MemoTileType MONKEY = new MemoTileType(4, "ms-appx:///Assets/images/monkey.png");
        private static readonly MemoTileType PARROT = new MemoTileType(5, "ms-appx:///Assets/images/parrot.png");
        private static readonly MemoTileType SNAKE = new MemoTileType(6, "ms-appx:///Assets/images/snake.png");
        private static readonly MemoTileType TIGER = new MemoTileType(7, "ms-appx:///Assets/images/tiger.png");

        private MemoTileType(int index, String imageName)
        {
            this.index = index;
            this.tileTypeImage = new BitmapImage(new Uri(imageName));
            instance[index] = this;
        }


        public static explicit operator MemoTileType(int index)
        {
            MemoTileType result;
            if (instance.TryGetValue(index, out result))
                return result;
            else
                throw new InvalidCastException();
        }
        public BitmapImage TileTypeImage { get { return tileTypeImage; }}

    }
}
