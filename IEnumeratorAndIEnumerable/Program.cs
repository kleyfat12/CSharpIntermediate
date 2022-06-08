using IEnumeratorAndIEnumerable;

Box box = new Box("My Box");
foreach (Ball ball in box)
{
    ball.Show();
}
foreach (Ball ball in box)
{
    ball.Show();
}
