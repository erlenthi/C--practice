int[] cashTill1 = { 1, 2, 3 };

// 1️⃣ Directly modify elements
cashTill1[0] += 1; // cashTill1 is now {2, 2, 3}

// 2️⃣ Reassign the reference
int[] cashTill2 = { 2, 2, 3 };
cashTill1 = cashTill2; // cashTill1 now **points to cashTill2**, previous array {2,2,3} is unchanged

// 3️⃣ Copy contents from another array
int[] cashTill3 = { 2, 2, 3 };
Array.Copy(cashTill1, cashTill3, cashTill1.Length); 
// cashTill3 is now updated to match cashTill1, cashTill1 itself is unchanged


// 4️⃣ Clone to make a new independent array
int[] cashTill4 = (int[])cashTill1.Clone(); 
cashTill4[0] = 99; // modifies cashTill4 only, cashTill1 stays the same