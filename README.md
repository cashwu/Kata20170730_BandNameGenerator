# [Band name generator](https://www.codewars.com/kata/59727ff285281a44e3000011)

---

My friend wants a new band name for her band. She like bands that use the formula: 'The' + a noun with first letter capitalized.

dolphin -> The Dolphin

However, when a noun STARTS and ENDS with the same letter, she likes to repeat the noun twice and connect them together with the first and last letter, combined into one word like so (WITHOUT a 'The' in front):

alaska -> Alaskalaska

europe -> Europeurope

Can you write a function that takes in a noun as a string, and returns her preferred band name written as a string?

---

### 中文大意

如果第一個字元和最後一個字元相同時，重覆捨棄第一個字元的文字一次，不相同時，開頭加上 The ，每個文字的首字需大寫
