<template >
    <div class="container-table">
        <table>
            <thead>
                <tr>
                    <th>Mã nhân viên</th>
                    <th>Họ và tên</th>
                    <th>Giới tính</th>
                    <th>Ngày sinh</th>
                    <th>Số diện thoại</th>
                    <th>Email</th>
                    <th>Chức vụ</th>
                    <th>Phòng ban</th>
                    <th>Mức lương cơ bản</th>
                    <th>Tình trạng công việc</th>
                </tr>
            </thead>
            <tbody>
                <tr v-for="employee in listEmployee" :key="employee">
                    <td>{{employee.code}}</td>
                    <td>{{employee.name}}</td>
                    <td>{{employee.sex}}</td>
                    <td>{{employee.birthday}}</td>
                    <td>{{employee.phone}}</td>
                    <td>{{employee.email}}</td>
                    <td>{{employee.position}}</td>
                    <td>{{employee.department}}</td>
                    <td>{{employee.salary}}</td>
                    <td>{{employee.jobStatus}}</td>
                </tr>
            </tbody>
        
           
            
        </table>
    </div>
</template>

<script>
export default {
  name: "employeetable",
  props:{
      listEmployee:{
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
     padding: 0px 10px;
     
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