// n friends numbered from 0 to n-1 are attending to a party
// infinite number of chairs numbered from 0 to infinity
// when a friend arrives at the party, they sit on the unoccupied chair with the smallest number

// ex : 0, 1, 5 chair is occupied so the friend sits on the chair number 2 

// when a friend leaves the party, thier chair becomes unoccupied at the moment they leave
// if another friend arrives at the same moment, they can sit on that chair

// you are given a 0-indexed 2D array times, where times[i] = [arrival, leaving], indicating the arrival and leaving times of the ith friend
// an integer target friend 
// return the chair number that the friend numbered targetFriend will sit on

// explication 

// times = [[1,4], [2,3], [4,6]], targetFriend = 1, times[i] = friend 
// output = 1 here is why

// friend 0 arrives at the time 1 and sits on the chair 0
// friend 1 arrives at the time 2 and sits on the chair 1
// friend 1 leaves at the time 3 and chair 1 becomes empty
// friend 0 leaves at the time 4 and chair 0 becomes empty
// friend 2 arrives at the time 4 and sits on chair 0

// so the friend 1 sat on chair 1, return 1

// times = [[3,10],[1,5],[2,6]] foreach([arrival, leaving] in array) array.sort(arrivala - arrivalb)

/**
 * @param {number[][]} times
 * @param {number} targetFriend
 * @return {number}
 */

var smallestChair = (times, targetFriend) => {
    let n = times.length;
    
    // Create a list of arrivals with friend index
    let arrivals = [];
    for (let i = 0; i < n; i++) {
        arrivals.push([times[i][0], i]);
    }
    
    // Sort friends by arrival time
    arrivals.sort((a, b) => a[0] - b[0]);
    
    // Min-Heap to track available chairs
    let availableChairs = new MinPriorityQueue({priority: x => x});
    for (let i = 0; i < n; i++) {
        availableChairs.enqueue(i);
    }

    // Priority queue to track when chairs are freed
    let leavingQueue = new MinPriorityQueue({priority: x => x[0]});
    
    // Iterate through each friend based on arrival
    for (let [arrivalTime, friendIndex] of arrivals) {
        // Free chairs that are vacated before the current arrival time
        while (!leavingQueue.isEmpty() && leavingQueue.front().element[0] <= arrivalTime) {
            availableChairs.enqueue(leavingQueue.dequeue().element[1]);
        }
        
        // Assign the smallest available chair
        let chair = availableChairs.dequeue().element;
        
        // If this is the target friend, return their chair number
        if (friendIndex === targetFriend) {
            return chair;
        }
        
        // Mark the chair as being used until the friend's leave time
        leavingQueue.enqueue([times[friendIndex][1], chair]);
    }
    
    return -1;
}
