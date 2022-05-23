public class MyStack {

    public Queue<int> q1;
    
    public MyStack() {
        this.q1= new Queue<int>();
        
    }
    
    public void Push(int x) {
        this.q1.Enqueue(x);
    }
    
    public int Pop() {
        if(this.q1.Count>0)
        {
            this.q1 = new Queue<int>(q1.Reverse());
            int popItem = this.q1.Peek();
            this.q1.Dequeue();
            this.q1 = new Queue<int>(q1.Reverse());
            return popItem;
        }
        else
        {
            return -1;
        }
    }
    
    public int Top() {
         if(this.q1.Count>0)
        {
            this.q1 = new Queue<int>(q1.Reverse());
            int popItem = this.q1.Peek();
            this.q1 = new Queue<int>(q1.Reverse());
            return popItem;
        }
        else
        {
            return -1;
        }
    }
    
    public bool Empty() {
        return this.q1.Count==0?true:false;
    }
}