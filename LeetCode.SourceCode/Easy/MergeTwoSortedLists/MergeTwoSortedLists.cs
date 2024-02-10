
using LeetCode.SourceCode.Structures;

namespace LeetCode.SourceCode.Easy;
public class MergeTwoSortedListsSolution {
    private static int CompareListNode(ListNode list1, ListNode list2) => list1.val.CompareTo(list2.val);
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        var resultList=new ListNode();
        var currentList1=list1;
        var currentList2=list2;
        while(true) {

        }
        return resultList;
    }
}