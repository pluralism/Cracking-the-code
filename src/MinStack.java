public class MinStack extends Stack<Integer> {
  Stack<Integer> stack2;

  public MinStack() {
    stack2 = new Stack<Integer>();
  }

  public void push(int value) {
    if(value <= min()) {
      stack2.push(value);
    }
    super.push(value);
  }

  public Integer() pop() {
    int value = super.pop();
    if(value == min()) {
      stack2.pop();
    }
    return value;
  }

  public int min() {
    if(stack2.isEmpty()) {
      return Integer.MAX_VALUE;
    } else {
      // Look at the object at the top without removing it
      return stack2.peek();
    }
  }
}
