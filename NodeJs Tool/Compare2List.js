var List1 = `
id
uid
parent_uid
group_type_uid
name
description
thumb_images
order_number
is_active
is_delete
create_at
modify_at
create_time
modify_time
tmp_product_uid
`;

var List2 = `
id
uid 
name
description 

is_active
modify_time
create_time
is_delete
images
thumb_images
order_number 
parent_uid 
group_type_uid 

modify_at 
create_at

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