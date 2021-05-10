<template >
    <div class="container-table">
        <table>
            <thead>
                <tr>
                    <th>Mã khách hàng</th>
                    <th>Họ và tên</th>
                    <th>Giới tính</th>
                    <th>Ngày sinh</th>
                    <th>Số diện thoại</th>
                    <th>Email</th>
                    <th>Nhóm khách hàng</th>
                    
                   
                    <th>Ghi chú</th>
                </tr>
            </thead>
            <tbody>
                <tr v-for="customer in listCustomer" :key="customer">
                    <td>{{customer.code}}</td>
                    <td>{{customer.name}}</td>
                    <td>{{customer.sex}}</td>
                    <td>{{customer.birthday}}</td>
                    <td>{{customer.phone}}</td>
                    <td>{{customer.email}}</td>
                    <td>{{customer.customerGroupName}}</td>
                    <td>{{customer.status}}</td>
                </tr>
            </tbody>
        
           
            
        </table>
    </div>
</template>

<script>
export default {
  name: "customertable",
  props:{
      listCustomer:{
          typeof: JSON,
          default: null
      }
  }
}
</script>
 <style>
 .container-table{
     width: 100%;
     position: relative;
     height: 690px;
     overflow-y: auto;
     margin-top: 10px;
 }
 .container-table::-webkit-scrollbar{
     background-color: #808080;
     width: 6px;
     height: 60px;
 }
 .container-table::-webkit-scrollbar-thumb{
     border-top-right-radius: 6px;
 }
 table{
     width: 100%;
     border-spacing: 0;
 }
    tr:nth-child(even){
        background-color: #FAFAFA;
    }
    tr{
        text-align: center;
        height: 40px;
    }
    tr:hover td{
        background-color: #6ccea8;
    }
    .container-table thead th{
        position: sticky;
        top: 0;
        background-color: #FFFFFF;
    }
    th, td {
        border-bottom: 1px solid #ddd;
    }

 
 

 </style>