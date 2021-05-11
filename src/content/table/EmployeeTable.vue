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
                    <th>Mã thẻ thành viên</th>
                    <th>Địa chỉ</th>
                    <th>Mức lương</th>
                </tr>
            </thead>
            <tbody>
                <tr v-for="employee in listEmployee" :key="employee.EmployeeCode">
                    <td>{{employee.EmployeeCode}}</td>
                    <td>{{employee.FullName}}</td>
                    <td>{{employee.GenderName}}</td>
                    <td>{{employee.DateOfBirth}}</td>
                    <td>{{employee.PhoneNumber}}</td>
                    <td>{{employee.Email}}</td>
                    <td>{{employee.PersonalTaxCode}}</td>
                    <td>{{employee.Address}}</td>
                    <td>{{employee.Salary}}</td>
                </tr>
            </tbody>
        
        
            
        </table>
    </div>
</template>

<script>

import axios from 'axios'
// import common from '../../js/common'


export default {
  name: "customertable",
//   props:{
//       listCustomer:{
//           typeof: JSON,
//           default: null
//       }
//   },
  data(){
     return{
         listEmployee: null
     }
  },
  mounted() {   
    axios.get('http://cukcuk.manhnv.net/v1/Employees')
    .then(response => {
      this.listEmployee = response.data 
    })
    .catch(e => {
      alert(e)
    })
  },
  methods:{
    
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