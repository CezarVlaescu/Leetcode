class MaxHeap {
    constructor() {
        this.heap = [];
    }
    
    // Helper to swap elements
    swap(i, j) {
        [this.heap[i], this.heap[j]] = [this.heap[j], this.heap[i]];
    }
    
    // Push a new value into the heap
    push(val) {
        this.heap.push(val);
        this.bubbleUp();
    }
    
    // Remove and return the maximum element from the heap
    pop() {
        if (this.heap.length === 1) return this.heap.pop();
        
        const max = this.heap[0];
        this.heap[0] = this.heap.pop();
        this.bubbleDown();
        return max;
    }
    
    // Bubble up the last inserted value to maintain max-heap property
    bubbleUp() {
        let idx = this.heap.length - 1;
        let parent = Math.floor((idx - 1) / 2);
        
        while (parent >= 0 && this.heap[parent] < this.heap[idx]) {
            this.swap(idx, parent);
            idx = parent;
            parent = Math.floor((idx - 1) / 2);
        }
    }
    
    // Bubble down the root value to maintain max-heap property
    bubbleDown() {
        let idx = 0;
        let leftChild = 2 * idx + 1;
        let rightChild = 2 * idx + 2;
        let largest = idx;
        
        if (leftChild < this.heap.length && this.heap[leftChild] > this.heap[largest]) {
            largest = leftChild;
        }
        
        if (rightChild < this.heap.length && this.heap[rightChild] > this.heap[largest]) {
            largest = rightChild;
        }
        
        if (largest !== idx) {
            this.swap(idx, largest);
            this.bubbleDown();
        }
    }
}

// Function to calculate the maximum score after k operations
var maxKElements = (nums, k) => {
    let heap = new MaxHeap();
    let finalScore = 0;

    // Initialize the max heap with all the elements from nums
    for (let num of nums) {
        heap.push(num);
    }

    // Perform k operations
    while (k > 0) {
        // Extract the maximum element
        let maxVal = heap.pop();
        
        // Add it to the final score
        finalScore += maxVal;
        
        // Push the ceiling of maxVal / 3 back into the heap
        heap.push(Math.ceil(maxVal / 3));
        
        k--;
    }
    
    return finalScore;
}

console.log(maxKElements([1, 10, 3, 3, 3], 3)); // Output: 17
