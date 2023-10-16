const test = require("node:test")
const assert = require("assert")

const bubbleSort = (myTable) => {
  let change, temp

  do {
    change = false

    for (let i = myTable.length - 1; i > 0; i--) {
      if (myTable[i] < myTable[i - 1]) {
        temp = myTable[i - 1]
        myTable[i - 1] = myTable[i]
        myTable[i] = temp
        change = true
      }
    }
  } while (change)

  return myTable
}

test("testing bubblesort", (t) => {
  let array = [5, 3, 65, 23, 1, 9, 0, 45]
  let expectedResult = [0, 1, 3, 5, 9, 23, 45, 65]

  let result = bubbleSort(array)
  console.log(result)
  assert.deepStrictEqual(result, expectedResult)
})
