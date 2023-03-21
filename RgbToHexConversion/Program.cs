public class Program
{
  public static string Rgb(int r, int g, int b) 
  {
   return $"{(r > 255 ? 255.ToString("X2") : ( r > 0 ? r.ToString("X2") : 0.ToString("X2")))}{(g > 255 ? 255.ToString("X2") : (g > 0 ? g.ToString("X2") : 0.ToString("X2")))}{(b > 255 ? 255.ToString("X2") : (b > 0 ? b.ToString("X2") : 0.ToString("X2")))}"; 
  }
}