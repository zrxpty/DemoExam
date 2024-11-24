

namespace DemoExam.WinForm.Features.Utils
{
    internal static class GenerateCaptcha
    {
        private static readonly Random Random = new Random();

        public static string GenerateCaptchaText(int length = 5)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789qwertyuiopasdfghjklzxcvbnm";
            char[] captchaText = new char[length];

            for (int i = 0; i < length; i++)
            {
                captchaText[i] = chars[Random.Next(chars.Length)];
            }

            return new string(captchaText);
        }

        public static Image GenerateCaptchaImage(string captchaText, int width = 200, int height = 80)
        {
            Bitmap bitmap = new Bitmap(width, height);

            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                graphics.Clear(Color.White);
                AddNoise(graphics, width, height);

                using (Font font = new Font("Arial", 32, FontStyle.Bold))
                using (Brush brush = new SolidBrush(Color.Black))
                {
                    SizeF textSize = graphics.MeasureString(captchaText, font);
                    float x = (width - textSize.Width) / 2;
                    float y = (height - textSize.Height) / 2;

                    graphics.DrawString(captchaText, font, brush, x, y);
                }
            }

            return bitmap;
        }

        private static void AddNoise(Graphics graphics, int width, int height)
        {
            using (Pen pen = new Pen(Color.LightGray))
            {
                for (int i = 0; i < 50; i++)
                {
                    int x1 = Random.Next(width);
                    int y1 = Random.Next(height);
                    int x2 = Random.Next(width);
                    int y2 = Random.Next(height);
                    graphics.DrawLine(pen, x1, y1, x2, y2);
                }
            }
        }
    }
}
