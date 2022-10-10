namespace Source;

public partial class GDI_Form : Form
{
    public Graphics Graphics { get; set; }
    public Pen Pen { get; set; }
    public Brush Brush { get; set; }


    public GDI_Form()
    {
        InitializeComponent();

        Graphics = CreateGraphics();
        Pen = new Pen(Color.DeepSkyBlue, 4);
        Brush = new SolidBrush(Color.Green);
    }

    private void Form1_MouseMove(object sender, MouseEventArgs e)
    {
        label1.Text = e.Location.ToString();
    }


    private void button_Click(object sender, EventArgs e)
    {
        if (sender is Button btn)
        {
            var points = new Point[]
            {
                new Point(290,290),
                new Point(345,264),
                new Point(453,335),
                new Point(351,396),
                new Point(290,290)
            };



            switch (btn.Text)
            {
                case "Line":
                    Graphics.DrawLine(Pen, 180, 20, 520, 40);
                    break;
                case "Circle":
                    Graphics.DrawEllipse(Pen, 179, 89, 102, 102);
                    Graphics.FillEllipse(Brush, 180, 90, 100, 100);
                    break;
                case "Rectangle":
                    Graphics.DrawRectangle(Pen, 179, 199, 102, 102);
                    Graphics.FillRectangle(Brush, 180, 200, 100, 100);
                    break;
                case "Polygon":

                    // Graphics.DrawPolygon(Pen, points);
                    Graphics.FillPolygon(Brush, points);

                    break;
                case "Arc":
                    var rect = new Rectangle(500, 300, 200, 200);
                    Graphics.DrawArc(Pen, rect, 0, 180);
                    break;
                case "Curve":
                    Graphics.FillClosedCurve(Brush, points);
                    break;
                case "Text":
                    var font = new Font("Rockwell", 25);
                    // var format = new StringFormat();
                    // format.FormatFlags = StringFormatFlags.DirectionVertical;
                    Graphics.DrawString("Hello Programmers! 4214", font, Brush, 300, 600);
                    break;
            }
        }
    }
}