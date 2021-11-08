export const intervalElementsCount = (
  input: Array<any>,
  startIndex: number,
  endIndex: number
) => {
  return input.filter((_, index) => index >= startIndex && index <= endIndex)
    .length;
};

const input = ["my value", 1, 5, "test value", 3];
const result = intervalElementsCount(input, 1, 3);

console.log(result); // -> output: 3
