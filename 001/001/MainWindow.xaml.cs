using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _001
{
    class Tile
    {
        public Button button { get; set; }
        public int wantedValue { get; set; }

        public Tile (Button button, int wantedValue)
        {
            this.button = button;
            this.wantedValue = wantedValue;
        }
    }


    public partial class MainWindow : Window
    {
        List<Tile> tiles;

        public MainWindow()
        {
            InitializeComponent();

            FillTiles();
            Shuffle();
        }

        private void FillTiles()
        {
            tiles = new List<Tile>();
            tiles.Add(new Tile(button1, 1));
            tiles.Add(new Tile(button2, 2));
            tiles.Add(new Tile(button3, 3));
            tiles.Add(new Tile(button4, 4));
            tiles.Add(new Tile(button5, 5));
            tiles.Add(new Tile(button6, 6));
            tiles.Add(new Tile(button7, 7));
            tiles.Add(new Tile(button8, 8));
            tiles.Add(new Tile(button9, 9));
            tiles.Add(new Tile(button10, 10));
            tiles.Add(new Tile(button11, 11));
            tiles.Add(new Tile(button12, 12));
            tiles.Add(new Tile(button13, 13));
            tiles.Add(new Tile(button14, 14));
            tiles.Add(new Tile(button15, 15));
            tiles.Add(new Tile(button16, 0));
        }

        private void Shuffle()
        {
            Random rnd = new Random();

            foreach(Tile t in tiles)
            {
                int randomPosition = rnd.Next(0, 15);
                string b = tiles[randomPosition].button.Content.ToString();
                tiles[randomPosition].button.Content = t.button.Content;
                t.button.Content = b;
            }
        }

        private void CheckWin()
        {
            bool win = true;

            foreach (Tile t in tiles)
            {
                if(t.button.Content.ToString() != "" && Convert.ToInt32(t.button.Content.ToString()) != t.wantedValue)
                {
                    win = false;
                }
            }

            if(win)
            {
                foreach(Tile t in tiles)
                {
                    t.button.IsEnabled = false;
                }
            }
        }

        private void resetButton_Click(object sender, RoutedEventArgs e)
        {
            foreach (Tile t in tiles)
            {
                t.button.IsEnabled = true;
            }
            Shuffle();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            foreach(Tile t in tiles)
            {
                //look for clicked button in tiles list
                if(t.button.Content == (sender as Button).Content)
                {
                    //check if switch is legal and switch if it is
                    int position = t.wantedValue;
                    switch(position)
                    {
                        case 1:
                            checkRight(position);
                            checkBottom(position);
                            break;
                        case 2: case 3:
                            checkLeft(position);
                            checkRight(position);
                            checkBottom(position);
                            break;
                        case 4:
                            checkLeft(position);
                            checkBottom(position);
                            break;
                        case 5: case 9:
                            checkTop(position);
                            checkRight(position);
                            checkBottom(position);
                            break;
                        case 6: case 7: case 10: case 11:
                            checkLeft(position);
                            checkTop(position);
                            checkRight(position);
                            checkBottom(position);
                            break;
                        case 8: case 12:
                            checkLeft(position);
                            checkTop(position);
                            checkBottom(position);
                            break;
                        case 13:
                            checkTop(position);
                            checkRight(position);
                            break;
                        case 14: case 15:
                            checkTop(position);
                            checkLeft(position);
                            checkRight(position);
                            break;
                        case 0:
                            checkTop(16);
                            checkLeft(16);
                            break;

                    }
                }
            }

            CheckWin();
        }

        private void checkLeft(int position)
        {
            position--;
            if(tiles[position-1].button.Content.ToString() == "")
            {
                tiles[position - 1].button.Content = tiles[position].button.Content;
                tiles[position].button.Content = "";
            }
        }

        private void checkRight(int position)
        {
            position--;
            if (tiles[position + 1].button.Content.ToString() == "")
            {
                tiles[position + 1].button.Content = tiles[position].button.Content;
                tiles[position].button.Content = "";
            }
        }

        private void checkBottom(int position)
        {
            position--;
            if (tiles[position + 4].button.Content.ToString() == "")
            {
                tiles[position + 4].button.Content = tiles[position].button.Content;
                tiles[position].button.Content = "";
            }
        }

        private void checkTop(int position)
        {
            position--;
            if (tiles[position - 4].button.Content.ToString() == "")
            {
                tiles[position - 4].button.Content = tiles[position].button.Content;
                tiles[position].button.Content = "";
            }
        }
    }
}
