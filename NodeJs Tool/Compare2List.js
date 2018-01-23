var List1 = `
id 
uid 
level_uid
department_uid 
name
description 
is_active
is_delete 
create_time
modify_time 
create_at 
modify_at
`;

var List2 = `
id
uid
level_uid
department_uid
name
description
is_active
is_delete
create_time
modify_time
create_at
modify_at
`;

var tempList1 = List1.split(' ').join('').split("\n");
var tempList2 = List2.split(' ').join('').split("\n");
var list2Missing = [];
var list1Missing = [];
tempList1.forEach(function (item, index) {
    if (!tempList2.includes(item.trim())) {
        list2Missing.push(item)
    }
})

tempList2.forEach(function (item, index) {
    if (!tempList1.includes(item)) {
        list1Missing.push(item)
    }
})

console.log("List 1 thiếu những phần tử sau: ", list1Missing.join(",").toString());
console.log("List 2 thiếu những phần tử sau: ", list2Missing.join(",").toString());