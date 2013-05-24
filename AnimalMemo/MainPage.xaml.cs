using AnimalMemo.model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace AnimalMemo
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        MemoModel model;

        public MainPage()
        {
            this.InitializeComponent();
            initializeMemoGrid();
            model = new MemoModel();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void initializeMemoGrid()
        {
            int gridSize = 4;
            

            for (int i = 0; i < gridSize; i++)
            {
                MemoGrid.RowDefinitions.Add(new RowDefinition());
                MemoGrid.ColumnDefinitions.Add(new ColumnDefinition());
            }

            for(int i = 0; i < gridSize; i++)
            {
                for (int j = 0; j < gridSize; j++)
                {

                    FrameworkElement element = getGridElement((i * gridSize + j).ToString());
                    Grid.SetRow(element, i);
                    Grid.SetColumn(element, j);
                    MemoGrid.Children.Add(element);
                }
            }
        }

        private FrameworkElement getGridElement(String tag)
        {
            Button button = new Button();
            button.Content = "Memo";
            button.HorizontalAlignment = HorizontalAlignment.Stretch;
            button.VerticalAlignment = VerticalAlignment.Stretch;
            button.FontFamily = new FontFamily("Segoe Print");
            button.Click += Button_Click;
            button.Tag = tag;

            //            VisualStateGroup stateGroup = new VisualStateGroup();

            //VisualTransition transition = new VisualTransition();
            //transition.To = "MouseOver";
            //Duration duration = new Duration(new TimeSpan(0, 0, 0, 1));
            //            transition.GeneratedDuration = duration;

            //            VisualTransition transition2 = new VisualTransition();
            //        transition2.To = "Pressed";
    //        transition2.GeneratedDuration = duration;
           
    //       stateGroup.Transitions.Add(transition);
  //          stateGroup.Transitions.Add(transition2);

//            VisualState state = new VisualState();
            //stateGroup.States.Add(state);

            //VisualStateManager.GetVisualStateGroups(button).Add(stateGroup);

            
            //    Vis`
            //<VisualStateManager.VisualStateGroups>
            //            <VisualStateGroup x:Name="CommonStates">
            //                <VisualStateGroup.Transitions>
            //                    <VisualTransition To="MouseOver" GeneratedDuration="0:0:0.1"/>
            //                    <VisualTransition To="Pressed" GeneratedDuration="0:0:0.1"/>
            //                </VisualStateGroup.Transitions>
            //                <VisualState x:Name="Normal" />
            //                <VisualState x:Name="MouseOver">
            //                    <Storyboard>
            //                        <ColorAnimation Storyboard.TargetName="BorderBrush" 
            //                                        Storyboard.TargetProperty="Color" 
            //                                        To="Yellow" />
            //                    </Storyboard>
            //                </VisualState>
            //                <VisualState x:Name="Pressed">
            //                    <Storyboard>
            //                        <ColorAnimation Storyboard.TargetName="BorderBrush" 
            //                                        Storyboard.TargetProperty="Color"
            //                                        To="Black"/>
            //                    </Storyboard>
            //                </VisualState>
            //            </VisualStateGroup>
            //        </VisualStateManager.VisualStateGroups>
            
            return button;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = (sender as Button);
            string tag = button.Tag.ToString();
            int index = int.Parse(tag);

            BitmapImage image = model.getMemoTile(index).Type.TileTypeImage;

            button.Content = "";
            ImageBrush brush = new ImageBrush();
            brush.ImageSource = image;
            brush.Stretch = Stretch.Uniform;
            button.Background = brush;
            //button  model.getMemoTile(index);

        }
    }
}
