using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_ListView
{
    class VideoGame
    {
        private string m_GameName;
        private string m_Rating;
        private double m_Price;

        public string GameName
        {
            get
            {
                return m_GameName;
            }

            set
            {
                m_GameName = value;

            }
        }

        public string Rating
        {
            get
            {
                return m_Rating;
            }

            set
            {
                m_Rating = value;

            }
        }

        public double Price
        {
            get
            {
                return m_Price;
            }

            set
            {
                m_Price = value;

            }
        }

        public VideoGame()
        {
            GameName = " ";
            Rating = " ";
            Price = 0.0;
        }

    }
}
