namespace TestSibirProject;
using NUnit.Framework;
public class PaginationHelperTest
{
    [Test]
    public void TotalItemCount_ReturnsCorrectCount()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
        int itemsPerPage = 3;
        PaginationHelper<int> helper = new PaginationHelper<int>(numbers, itemsPerPage);

        Assert.AreEqual(15, helper.ItemCount);
    }

    [Test]
    public void PageCount_ReturnsCorrectCount()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
        int itemsPerPage = 3;
        PaginationHelper<int> helper = new PaginationHelper<int>(numbers, itemsPerPage);

        Assert.AreEqual(5, helper.PageCount);
    }

    [Test]
    public void PageItemCount_ReturnsCorrectCount()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
        int itemsPerPage = 3;
        PaginationHelper<int> helper = new PaginationHelper<int>(numbers, itemsPerPage);

        Assert.AreEqual(3, helper.PageItemCount(1));
        Assert.AreEqual(0, helper.PageItemCount(4));
    }

    [Test]
    public void PageIndex_ReturnsCorrectIndex()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
        int itemsPerPage = 3;
        PaginationHelper<int> helper = new PaginationHelper<int>(numbers, itemsPerPage);

        Assert.AreEqual(1, helper.PageIndex(4));
        Assert.AreEqual(2, helper.PageIndex(8));
    }
}