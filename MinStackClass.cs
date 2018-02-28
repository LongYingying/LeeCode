using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    #region
/*Design a stack that supports push, pop, top, and retrieving the minimum element in constant time.

push(x) -- Push element x onto stack.
pop() -- Removes the element on top of the stack.
top() -- Get the top element.
getMin() -- Retrieve the minimum element in the stack.
*/
class MinStackClass
{
    List<int> stack = null;
    int Min;
    public MinStackClass()
    {
        stack = new List<int>();
    }

    public void Push(int x)
    {
        stack.Add(x);
    }

    public void Pop()
    {
        stack.RemoveAt(stack.Count - 1);
    }

    public int Top()
    {
            if (stack.Count > 0)
            {
                return stack[stack.Count - 1];
            }
            else
                return 0;

    }

    public int GetMin()
    {

        if(stack.Count>0)
        {
            Min = stack[0];
            foreach (int i in stack)
            {
                if (i < Min)
                    Min = i;
            }
        }
        return Min;
    }
}
#endregion
}
