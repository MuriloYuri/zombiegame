﻿using System;
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
using ZombieGame.Game;
using ZombieGame.Game.Serializable;
using ZombieGame.Game.Enums;

namespace ZombieGame.UI
{
    /// <summary>
    /// Interaction logic for StoreUC.xaml
    /// </summary>
    public partial class StoreUC : UserControl
    {
        #region Properties
        public int MaxWIndex, MaxPIndex;
        public int CurWIndex = 0, CurPIndex = 0;
        public SimpleWeapon w1, w2, w3, w4;
        public SimpleProjectile p1, p2, p3, p4;
        public bool IsOpen = false;
        #endregion

        #region Methods

        private void btnWeaponsLeft_Click(object sender, RoutedEventArgs e)
        {
            if (CurWIndex > 0)
            {
                CurWIndex--;
                SetSellingWeapons();
            }

            if (CurWIndex == 0)
                btnWeaponsLeft.IsEnabled = false;
            btnWeaponsRight.IsEnabled = true;
        }
        private void btnWeaponsRight_Click(object sender, RoutedEventArgs e)
        {
            if (CurWIndex < MaxWIndex)
            {
                CurWIndex++;
                SetSellingWeapons();
            }
            if (CurWIndex == MaxWIndex)
                btnWeaponsRight.IsEnabled = false;
            btnWeaponsLeft.IsEnabled = true;
        }
        private void btnProjectilesRight_Click(object sender, RoutedEventArgs e)
        {
            if (CurPIndex < MaxPIndex)
            {
                CurPIndex++;
                SetSellingProjectiles();
            }
            if (CurPIndex == MaxPIndex)
                btnProjectilesRight.IsEnabled = false;
            btnProjectilesLeft.IsEnabled = true;
        }
        private void btnProjectilesLeft_Click(object sender, RoutedEventArgs e)
        {
            if (CurPIndex > 0)
            {
                CurPIndex--;
                SetSellingProjectiles();
            }

            if (CurPIndex == 0)
                btnProjectilesLeft.IsEnabled = false;
            btnProjectilesRight.IsEnabled = true;
        }

        private void btnWeapon1_Click(object sender, RoutedEventArgs e)
        {
            if (btnWeapon1.Content.Equals("Comprar"))
            {
                Store.BuyWeapon(w1.ItemID);
                btnWeapon1.IsEnabled = false;
                SetSellingItens();
            }
            else if (btnWeapon1.Content.Equals("Equipar"))
            {
                if (GameMaster.Players[1].IsPlaying)
                {
                    //Abrir outra janela perguntando para qual dos players
                }
                else
                {
                    GameMaster.Players[0].Character.SetWeapon(w1.Mount());
                }
            }
            else
            {
                btnWeapon1.IsEnabled = false;
                Console.WriteLine("O botão weapon1 não deveria ser clicável!");
            }
        }
        private void btnWeapon2_Click(object sender, RoutedEventArgs e)
        {
            if (btnWeapon2.Content.Equals("Comprar"))
            {
                Store.BuyWeapon(w2.ItemID);
                btnWeapon2.IsEnabled = false;
                SetSellingItens();
            }
            else if (btnWeapon2.Content.Equals("Equipar"))
            {
                if (GameMaster.Players[1].IsPlaying)
                {
                    //Abrir outra janela perguntando para qual dos players
                }
                else
                {
                    GameMaster.Players[0].Character.SetWeapon(w2.Mount());
                }
            }
            else
            {
                btnWeapon2.IsEnabled = false;
                Console.WriteLine("O botão Weapon2 não deveria ser clicável!");
            }
        }
        private void btnWeapon3_Click(object sender, RoutedEventArgs e)
        {
            if (btnWeapon3.Content.Equals("Comprar"))
            {
                Store.BuyWeapon(w3.ItemID);
                btnWeapon3.IsEnabled = false;
                SetSellingItens();
            }
            else if (btnWeapon3.Content.Equals("Equipar"))
            {
                if (GameMaster.Players[1].IsPlaying)
                {
                    //Abrir outra janela perguntando para qual dos players
                }
                else
                {
                    GameMaster.Players[0].Character.SetWeapon(w3.Mount());
                }
            }
            else
            {
                btnWeapon3.IsEnabled = false;
                Console.WriteLine("O botão Weapon3 não deveria ser clicável!");
            }
        }
        private void btnWeapon4_Click(object sender, RoutedEventArgs e)
        {
            if (btnWeapon4.Content.Equals("Comprar"))
            {
                Store.BuyWeapon(w4.ItemID);
                btnWeapon4.IsEnabled = false;
                SetSellingItens();
            }
            else if (btnWeapon4.Content.Equals("Equipar"))
            {
                if (GameMaster.Players[1].IsPlaying)
                {
                    //Abrir outra janela perguntando para qual dos players
                }
                else
                {
                    GameMaster.Players[0].Character.SetWeapon(w4.Mount());
                }
            }
            else
            {
                btnWeapon4.IsEnabled = false;
                Console.WriteLine("O botão Weapon4 não deveria ser clicável!");
            }
        }
        private void btnProjectile1_Click(object sender, RoutedEventArgs e)
        {
            if (btnProjectile1.Content.Equals("Comprar"))
            {
                Store.BuyProjectile(p1.ItemID);
                btnProjectile1.IsEnabled = false;
                SetSellingProjectiles();
            }
            else if (btnProjectile1.Content.Equals("Equipar"))
            {
                if (GameMaster.Players[1].IsPlaying)
                {
                    //Abrir outra janela perguntando para qual dos players
                }
                else
                {
                    GameMaster.Players[0].Character.Weapon.SetProjectile(p1.Mount());
                }
            }
            else
            {
                btnProjectile1.IsEnabled = false;
                Console.WriteLine("O botão Projectile1 não deveria ser clicável!");
            }
        }
        private void btnProjectile2_Click(object sender, RoutedEventArgs e)
        {
            if (btnProjectile2.Content.Equals("Comprar"))
            {
                Store.BuyProjectile(p2.ItemID);
                btnProjectile2.IsEnabled = false;
                SetSellingProjectiles();
            }
            else if (btnProjectile2.Content.Equals("Equipar"))
            {
                if (GameMaster.Players[1].IsPlaying)
                {
                    //Abrir outra janela perguntando para qual dos players
                }
                else
                {
                    GameMaster.Players[0].Character.Weapon.SetProjectile(p2.Mount());
                }
            }
            else
            {
                btnProjectile2.IsEnabled = false;
                Console.WriteLine("O botão Projectile2 não deveria ser clicável!");
            }
        }
        private void btnProjectile3_Click(object sender, RoutedEventArgs e)
        {
            if (btnProjectile3.Content.Equals("Comprar"))
            {
                Store.BuyProjectile(p3.ItemID);
                btnProjectile3.IsEnabled = false;
                SetSellingProjectiles();
            }
            else if (btnProjectile3.Content.Equals("Equipar"))
            {
                if (GameMaster.Players[1].IsPlaying)
                {
                    //Abrir outra janela perguntando para qual dos players
                }
                else
                {
                    GameMaster.Players[0].Character.Weapon.SetProjectile(p3.Mount());
                }
            }
            else
            {
                btnProjectile3.IsEnabled = false;
                Console.WriteLine("O botão Projectile3 não deveria ser clicável!");
            }
        }
        private void btnProjectile4_Click(object sender, RoutedEventArgs e)
        {
            if (btnProjectile4.Content.Equals("Comprar"))
            {
                Store.BuyProjectile(p4.ItemID);
                btnProjectile4.IsEnabled = false;
                SetSellingProjectiles();
            }
            else if (btnProjectile4.Content.Equals("Equipar"))
            {
                if (GameMaster.Players[1].IsPlaying)
                {
                    //Abrir outra janela perguntando para qual dos players
                }
                else
                {
                    GameMaster.Players[0].Character.Weapon.SetProjectile(p4.Mount());
                }
            }
            else
            {
                btnProjectile4.IsEnabled = false;
                Console.WriteLine("O botão Projectile4 não deveria ser clicável!");
            }
        }

        public StoreUC()
        {
            InitializeComponent();
            Canvas.SetZIndex(this, Convert.ToInt32(ZIndexes.UserInterface));
        }
        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            CurWIndex = 0;
            CurPIndex = 0;
            SetMaxIndex();
            SetSellingItens();
            Width = Physics.Vector.WindowSize.X;
            Height = Physics.Vector.WindowSize.Y;
            Refresh();
            lblDinheiro.Content = "Dinheiro: " + GameMaster.Money;
        }
        public void Refresh()
        {
            TranslateTransform tt = new TranslateTransform();
            tt.X = GameMaster.Camera.RigidBody.Position.X;
            tt.Y = -GameMaster.Camera.RigidBody.Position.Y;
            RenderTransform = tt;
        }

        public void SetMaxIndex()
        {
            MaxWIndex = Store.SellingWeapons.Count - 4;
            MaxPIndex = Store.SellingProjectiles.Count - 4;
            if (MaxWIndex < 0)
                MaxWIndex = 0;
            if (MaxPIndex < 0)
                MaxPIndex = 0;
        }
        public void SetSellingItens()
        {
            SetSellingWeapons();
            SetSellingProjectiles();
        }
        public void SetSellingWeapons()
        {
            //Weapon1
            if (Store.SellingWeapons.Count > CurWIndex)
            {
                w1 = Store.SellingWeapons[CurWIndex + 0];
                imgWeapon1.Source =
                    new BitmapImage(
                        new Uri(IO.GlobalPaths.WeaponSprites + w1.SpriteFileName));
                lblWeapon1.Content = w1.Name;
                if (!w1.Sold)
                {
                    if (GameMaster.Money >= w1.Price)
                    {
                        btnWeapon1.Background = new SolidColorBrush(Color.FromRgb(31, 128, 31));
                        btnWeapon1.Content = "Comprar";
                        btnWeapon1.IsEnabled = true;
                    }
                    else
                    {
                        btnWeapon1.Background = new SolidColorBrush(Color.FromRgb(200, 0, 0));
                        btnWeapon1.Content = "Preço: " + w1.Price;
                        btnWeapon1.IsEnabled = false;
                    }
                }
                else
                {
                    btnWeapon1.Background = new SolidColorBrush(Color.FromRgb(200, 215, 70));
                    btnWeapon1.Content = "Equipar";
                    btnWeapon1.IsEnabled = true;
                }
            }
            else
            {
                w1 = null;
                btnWeapon1.Background = new SolidColorBrush(Color.FromRgb(110, 110, 110));
                btnWeapon1.Content = "";
                btnWeapon1.IsEnabled = false;
            }
            //Weapon2
            if (Store.SellingWeapons.Count > CurWIndex + 1)
            {
                w2 = Store.SellingWeapons[CurWIndex + 1];
                imgWeapon2.Source =
                    new BitmapImage(
                        new Uri(IO.GlobalPaths.WeaponSprites + w2.SpriteFileName));
                lblWeapon2.Content = w2.Name;
                if (!w2.Sold)
                {
                    if (GameMaster.Money >= w2.Price)
                    {
                        btnWeapon2.Background = new SolidColorBrush(Color.FromRgb(31, 128, 31));
                        btnWeapon2.Content = "Comprar";
                        btnWeapon2.IsEnabled = true;
                    }
                    else
                    {
                        btnWeapon2.Background = new SolidColorBrush(Color.FromRgb(200, 0, 0));
                        btnWeapon2.Content = "Preço: " + w2.Price;
                        btnWeapon2.IsEnabled = false;
                    }
                }
                else
                {
                    btnWeapon2.Background = new SolidColorBrush(Color.FromRgb(200, 215, 70));
                    btnWeapon2.Content = "Equipar";
                    btnWeapon2.IsEnabled = true;
                }
            }
            else
            {
                w2 = null;
                btnWeapon2.Background = new SolidColorBrush(Color.FromRgb(110, 110, 110));
                btnWeapon2.Content = "";
                btnWeapon2.IsEnabled = false;
            }
            //Weapon3
            if (Store.SellingWeapons.Count > CurWIndex + 2)
            {
                w3 = Store.SellingWeapons[CurWIndex + 2];
                imgWeapon3.Source =
                    new BitmapImage(
                        new Uri(IO.GlobalPaths.WeaponSprites + w3.SpriteFileName));
                lblWeapon3.Content = w3.Name;
                if (!w3.Sold)
                {
                    if (GameMaster.Money >= w3.Price)
                    {
                        btnWeapon3.Background = new SolidColorBrush(Color.FromRgb(31, 128, 31));
                        btnWeapon3.Content = "Comprar";
                        btnWeapon3.IsEnabled = true;
                    }
                    else
                    {
                        btnWeapon3.Background = new SolidColorBrush(Color.FromRgb(200, 0, 0));
                        btnWeapon3.Content = "Preço: " + w3.Price;
                        btnWeapon3.IsEnabled = false;
                    }
                }
                else
                {
                    btnWeapon3.Background = new SolidColorBrush(Color.FromRgb(200, 215, 70));
                    btnWeapon3.Content = "Equipar";
                    btnWeapon3.IsEnabled = true;
                }
            }
            else
            {
                w3 = null;
                btnWeapon3.Background = new SolidColorBrush(Color.FromRgb(110, 110, 110));
                btnWeapon3.Content = "";
                btnWeapon3.IsEnabled = false;
            }
            //Weapon4
            if (Store.SellingWeapons.Count > CurWIndex + 3)
            {
                w4 = Store.SellingWeapons[CurWIndex + 3];
                imgWeapon4.Source =
                    new BitmapImage(
                        new Uri(IO.GlobalPaths.WeaponSprites + w4.SpriteFileName));
                lblWeapon4.Content = w4.Name;
                if (!w4.Sold)
                {
                    if (GameMaster.Money >= w4.Price)
                    {
                        btnWeapon4.Background = new SolidColorBrush(Color.FromRgb(31, 128, 31));
                        btnWeapon4.Content = "Comprar";
                        btnWeapon4.IsEnabled = true;
                    }
                    else
                    {
                        btnWeapon4.Background = new SolidColorBrush(Color.FromRgb(200, 0, 0));
                        btnWeapon4.Content = "Preço: " + w4.Price;
                        btnWeapon4.IsEnabled = false;
                    }
                }
                else
                {
                    btnWeapon4.Background = new SolidColorBrush(Color.FromRgb(200, 215, 70));
                    btnWeapon4.Content = "Equipar";
                    btnWeapon4.IsEnabled = true;
                }
            }
            else
            {
                w4 = null;
                btnWeapon4.Background = new SolidColorBrush(Color.FromRgb(110, 110, 110));
                btnWeapon4.Content = "";
                btnWeapon4.IsEnabled = false;
            }
        }
        public void SetSellingProjectiles()
        {
            //Projectile1
            if (Store.SellingProjectiles.Count > CurPIndex + 0)
            {
                p1 = Store.SellingProjectiles[CurPIndex + 0];
                imgProjectile1.Source =
                    new BitmapImage(
                        new Uri(IO.GlobalPaths.ProjectileSprites + p1.SpriteFileName));
                lblProjectile1.Content = p1.Name;
                if (!p1.Sold)
                {
                    if (GameMaster.Money >= p1.Price)
                    {
                        btnProjectile1.Background = new SolidColorBrush(Color.FromRgb(31, 128, 31));
                        btnProjectile1.Content = "Comprar";
                        btnProjectile1.IsEnabled = true;
                    }
                    else
                    {
                        btnProjectile1.Background = new SolidColorBrush(Color.FromRgb(200, 0, 0));
                        btnProjectile1.Content = "Preço: " + p1.Price;
                        btnProjectile1.IsEnabled = false;
                    }
                }
                else if (GameMaster.Players[0].Character.Weapon.AcceptedProjectileTypes.Contains(p1.Type) ||
                    GameMaster.Players[1].Character.Weapon.AcceptedProjectileTypes.Contains(p1.Type))
                {
                    btnProjectile1.Background = new SolidColorBrush(Color.FromRgb(200, 215, 70));
                    btnProjectile1.Content = "Equipar";
                    btnProjectile1.IsEnabled = true;
                }
                else
                {
                    btnProjectile1.Background = new SolidColorBrush(Color.FromRgb(110, 110, 110));
                    btnProjectile1.Content = "Não compatível";
                    btnProjectile1.IsEnabled = false;
                }
            }
            else
            {
                p1 = null;
                btnProjectile1.Background = new SolidColorBrush(Color.FromRgb(110, 110, 110));
                btnProjectile1.Content = "";
                btnProjectile1.IsEnabled = false;
            }
            //Projectile2
            if (Store.SellingProjectiles.Count > CurPIndex + 1)
            {
                p2 = Store.SellingProjectiles[CurPIndex + 1];
                imgProjectile2.Source =
                    new BitmapImage(
                        new Uri(IO.GlobalPaths.ProjectileSprites + p2.SpriteFileName));
                lblProjectile2.Content = p2.Name;
                if (!p2.Sold)
                {
                    if (GameMaster.Money >= p2.Price)
                    {
                        btnProjectile2.Background = new SolidColorBrush(Color.FromRgb(31, 128, 31));
                        btnProjectile2.Content = "Comprar";
                        btnProjectile2.IsEnabled = true;
                    }
                    else
                    {
                        btnProjectile2.Background = new SolidColorBrush(Color.FromRgb(200, 0, 0));
                        btnProjectile2.Content = "Preço: " + p2.Price;
                        btnProjectile2.IsEnabled = false;
                    }
                }
                else
                {
                    btnProjectile2.Background = new SolidColorBrush(Color.FromRgb(200, 215, 70));
                    btnProjectile2.Content = "Equipar";
                    btnProjectile2.IsEnabled = true;
                }
            }
            else
            {
                p2 = null;
                btnProjectile2.Background = new SolidColorBrush(Color.FromRgb(110, 110, 110));
                btnProjectile2.Content = "";
                btnProjectile2.IsEnabled = false;
            }
            //Projectile3
            if (Store.SellingProjectiles.Count > CurPIndex + 2)
            {
                p3 = Store.SellingProjectiles[CurPIndex + 2];
                imgProjectile3.Source =
                    new BitmapImage(
                        new Uri(IO.GlobalPaths.ProjectileSprites + p3.SpriteFileName));
                lblProjectile3.Content = p3.Name;
                if (!p3.Sold)
                {
                    if (GameMaster.Money >= p3.Price)
                    {
                        btnProjectile3.Background = new SolidColorBrush(Color.FromRgb(31, 128, 31));
                        btnProjectile3.Content = "Comprar";
                        btnProjectile3.IsEnabled = true;
                    }
                    else
                    {
                        btnProjectile3.Background = new SolidColorBrush(Color.FromRgb(200, 0, 0));
                        btnProjectile3.Content = "Preço: " + p3.Price;
                        btnProjectile3.IsEnabled = false;
                    }
                }
                else
                {
                    btnProjectile3.Background = new SolidColorBrush(Color.FromRgb(200, 215, 70));
                    btnProjectile3.Content = "Equipar";
                    btnProjectile3.IsEnabled = true;
                }
            }
            else
            {
                p3 = null;
                btnProjectile3.Background = new SolidColorBrush(Color.FromRgb(110, 110, 110));
                btnProjectile3.Content = "";
                btnProjectile3.IsEnabled = false;
            }
            //Projectile4
            if (Store.SellingProjectiles.Count > CurPIndex + 3)
            {
                p4 = Store.SellingProjectiles[CurPIndex + 3];
                lblProjectile4.Content = p4.Name;
                imgProjectile4.Source =
                    new BitmapImage(
                        new Uri(IO.GlobalPaths.ProjectileSprites + p4.SpriteFileName));
                if (!p4.Sold)
                {
                    if (GameMaster.Money >= p4.Price)
                    {
                        btnProjectile4.Background = new SolidColorBrush(Color.FromRgb(31, 128, 31));
                        btnProjectile4.Content = "Comprar";
                        btnProjectile4.IsEnabled = true;
                    }
                    else
                    {
                        btnProjectile4.Background = new SolidColorBrush(Color.FromRgb(200, 0, 0));
                        btnProjectile4.Content = "Preço: " + p4.Price;
                        btnProjectile4.IsEnabled = false;
                    }
                }
                else
                {
                    btnProjectile4.Background = new SolidColorBrush(Color.FromRgb(200, 215, 70));
                    btnProjectile4.Content = "Equipar";
                    btnProjectile4.IsEnabled = true;
                }
            }
            else
            {
                p4 = null;
                btnProjectile4.Background = new SolidColorBrush(Color.FromRgb(110, 110, 110));
                btnProjectile4.Content = "";
                btnProjectile4.IsEnabled = false;
            }
        }
        #endregion
    }
}
