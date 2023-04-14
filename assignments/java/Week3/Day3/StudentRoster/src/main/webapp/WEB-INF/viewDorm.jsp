<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core"%>
<!-- for forms -->
<%@ taglib prefix="form" uri="http://www.springframework.org/tags/form" %>
<%@ taglib prefix = "fmt" uri = "http://java.sun.com/jsp/jstl/fmt" %>
<!-- for validation -->
<%@ page isErrorPage="true" %>
<!DOCTYPE html>
<html>
<head>
<!-- for Bootstrap CSS -->
<link rel="stylesheet" href="/webjars/bootstrap/css/bootstrap.min.css" />
<!-- YOUR own local CSS -->
<link rel="stylesheet" type="text/css" href="/css/style.css">
<!-- For any Bootstrap that uses JS -->
<script src="/webjars/bootstrap/js/bootstrap.min.js"></script>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>
	<div class="container my-5">
		<h1 class="display-3 mb-3 text-center">${dorm.name} Students</h1>
        <div>

				
        </div>
        <table class="table table-striped text-center mt-5 table-bordered fs-5">
            <thead>
                <th>Student</th>
                <th>Action</th>
            </thead>
            <tbody>
                <c:forEach var="s" items="${dorm.students}">
                    <tr>
                        <td>${s.firstName} ${s.lastName}</td>
                        <td><a href="#">Remove</a></td>
                    </tr>
                </c:forEach>
            </tbody>
        </table>
	</div>
</body>
</html>