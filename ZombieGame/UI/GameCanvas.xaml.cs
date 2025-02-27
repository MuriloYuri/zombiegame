﻿using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using ZombieGame.Game;
using ZombieGame.Physics;

namespace ZombieGame.UI
{
    /// <summary>
    /// Interaction logic for GameCanvas.xaml
    /// </summary>
    public partial class GameCanvas : UserControl
    {
        public GameCanvas()
        {
            InitializeComponent();
        }

        public void Prepare()
        {
            P1Stats.AssociatedPlayer = GameMaster.GetPlayer(0);
            P2Stats.AssociatedPlayer = GameMaster.GetPlayer(1);
            P1Stats.PlayerName.Content = "Player 1";
            P2Stats.PlayerName.Content = "Player 2";
            Time.HighFrequencyTimer.Elapsed += HighFrequencyTimer_Elapsed;
        }

        public void AddChild(UIElement element)
        {
            Canvas.Children.Add(element);
        }

        public void RemoveChild(UIElement element)
        {
            Canvas.Children.Remove(element);
        }

        public void ResetUI()
        {
            RemoveChild(ControlCache.PauseMenu);
        }

        public void HideUI()
        {
            P1Stats.Visibility = Visibility.Collapsed;
            P2Stats.Visibility = Visibility.Collapsed;
            GameInfo.Visibility = Visibility.Collapsed;
        }

        public void ShowUI()
        {
            P1Stats.Visibility = Visibility.Visible;
            P2Stats.Visibility = Visibility.Visible;
            GameInfo.Visibility = Visibility.Visible;
        }

        private void HighFrequencyTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            App.Current.Dispatcher.Invoke(delegate{ UpdateUI(); });
        }

        public void Reset()
        {
            var t0 = new TranslateTransform(0, 0);
            RenderTransform = t0;
            P1Stats.RenderTransform = t0;
            P2Stats.RenderTransform = t0;
            GameInfo.RenderTransform = t0;
        }

        public void UpdateUI()
        {
            Physics.Vector v = Game.Prefabs.Entities.Camera.GetTopLeftFocusPoint();
            RenderTransform = new TranslateTransform(-v.X, v.Y);
            P1Stats.RenderTransform = new TranslateTransform(v.X, -v.Y);
            P2Stats.RenderTransform = new TranslateTransform(v.X, -v.Y);
            GameInfo.RenderTransform = new TranslateTransform(v.X, -v.Y);

            P1Stats.UpdateStats();
            if (GameMaster.Players.Length > 1)
                P2Stats.UpdateStats();
            GameInfo.Update();
        }

    }
}
