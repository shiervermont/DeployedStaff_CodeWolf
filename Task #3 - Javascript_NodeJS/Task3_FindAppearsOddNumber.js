// Started at 3:12PM PHT

function findAppearsOddNumber(numberArray)
{
    let dictionary = {}; // JSON object to act as dictionary

    // Build the dictionary with unique numbers similar to C# Key/Value Pair
    for (const num of numberArray) {
        dictionary[num] = (dictionary[num] || 0) + 1;
    }

    // Find the first item with an odd count from the dictionary
    for (const num in dictionary) {
        if (dictionary[num] % 2 !== 0) {
            return parseInt(num);
        }
    }

    // No item appears as odd number of times
    return null;
}

// Finished at 3:37PM PHT