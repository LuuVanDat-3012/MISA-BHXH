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
                </tr>
            </thead>
            <tbody>
                <tr v-for="(customer, index) in listCustomer.data" :key="index"  @dblclick="showDialog()">
                    <td>{{customer.customerCode}}</td>
                    <td>{{customer.fullname}}</td>
                    <td>{{formatGender(customer.gender)}}</td>
                    <td>{{formatDate(customer.birthday)}}</td>
                    <td>{{customer.phone}}</td>
                    <td>{{customer.email}}</td>
                </tr>
            </tbody>
      
       
        </table>
    </div>
</template>

<script>
import axios from 'axios'
import common from '../../js/common'
export default {
  name: "customertable",
  data(){
     return{
         listCustomer: null,
         
     }
  },
 
  mounted() {   
    axios.get('https://localhost:44333/api/Customers')
    .then(response => {
      this.listCustomer = response.data;
    })
    .catch(e => {
      alert(e);
    })
  },

  methods:{
    formatDate(val){
        return common.formatDate(val);
    },
    formatGender(val){
        return common.formatGender(val);
    },
    showDialog(){
        this.$emit("clickToShowDialog");
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