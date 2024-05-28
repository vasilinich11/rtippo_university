﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;

namespace wheelOfFortune
{
    public class WheelOfFortune
    {
        private readonly Form1 form;
        private readonly Bitmap wheelPic;
        private readonly int[] states;
        private float angle;
        private int state;
        private int turnsCount;

        public Player Player { get; private set; }
        public readonly Timer wheelTimer;
        public bool wheelIsMoved;
        public int numberOfTwists;

        public WheelOfFortune(Form1 form, int turnsCount)
        {
            this.form = form;
            wheelPic = new Bitmap(Properties.Resources.wheel1);
            states = new int[] { 1, 2, 20, 1, 5, 2, 1, 10, 1, 2, 1, 5, 1, 40, 1, 2, 1, 2, 1, 5, 1, 10, 1, 2, 1, 2, 1, 5, 1, 20, 1, 2, 1, 2, 1, 10, 2, 5, 1, 2, 40, 2, 1, 2, 1, 5, 1, 2, 1, 10, 1, 5, 1, 2 };
            angle = 0.0f;
            this.turnsCount = turnsCount;
            Player = new Player(form);
            wheelTimer = new Timer();
            wheelTimer.Interval = 50;
            wheelTimer.Tick += WheelTimerTick;
        }

        private Bitmap RotateImage(Image image, float angle, PointF offset = default(PointF))
        {
            if (image == null)
            {
                throw new ArgumentNullException("image");
            }

            Bitmap rotatedBmp = new Bitmap(image.Width, image.Height);
            rotatedBmp.SetResolution(image.HorizontalResolution, image.VerticalResolution);
            Graphics g = Graphics.FromImage(rotatedBmp);

            if (offset == default(PointF))
            {
                offset = new PointF((float)image.Width / 2, (float)image.Height / 2);
            }

            g.TranslateTransform(offset.X, offset.Y);
            g.RotateTransform(angle);
            g.TranslateTransform(-offset.X, -offset.Y);
            g.DrawImage(image, new PointF(0, 0));

            return rotatedBmp;
        }

        private void EndGame()
        {
            form.PrepareNewGameUI();
            GetWinner();
        }

        private void GetWinner()
        {
            form.labelBalances.Visible = true;
            form.labelBalances.Text = $"Баланс: {Player.balance}";
            form.ShowWinner(Player);
        }

        private void WheelTimerTick(object sender, EventArgs e)
        {
            if (wheelIsMoved && numberOfTwists > 0)
            {
                angle += numberOfTwists / 10;
                angle = angle % 360;
                Bitmap rotatedImage = RotateImage(wheelPic, angle);
                form.pictureBoxWheel.Image = rotatedImage;
                numberOfTwists--;

                state = Convert.ToInt32(Math.Ceiling(angle / 6.666666666666667));

                if (state == 0)
                {
                    state = 0;
                }
                else
                {
                    state -= 1;
                }
            }
            else
            {
                wheelTimer.Stop();
                wheelIsMoved = false;
                GetResults();
            }
        }

        private void GetResults()
        {
            turnsCount--;

            int result = states[state];

            form.labelWinningSector.Visible = true;
            form.labelWinningSector.Text = $"Победный сектор {result}";

            form.labelPrizes.Text = "";
            form.labelPrizes.Visible = true;

            Player.CalculatePrize(result);

            if (turnsCount == 0)
            {
                EndGame();
                return;
            }

            form.PrepareNewTurnUI();
            form.labelBalance.Text = $"Баланс: {Player.balance}";
        }
    }
}
