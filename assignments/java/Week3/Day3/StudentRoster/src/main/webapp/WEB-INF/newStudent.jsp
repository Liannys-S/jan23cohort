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
	<div class="container my-5 fs-4">
        <h1 class="display-3">New Student</h1>
		<a href="/">Dashboard</a>

        <form:form action="/students/create" method="post" modelAttribute="student" class="mt-5">
            <div class="mb-3 col-4">
                <form:label class="form-label" path="firstName">First Name:</form:label>
                <form:input class="form-control" path="firstName"/>
                <form:errors class="text-danger" path="firstName"/>
            </div>
            <div class="mb-3 col-4">
                <form:label class="form-label" path="lastName">Last Name:</form:label>
                <form:input class="form-control" path="lastName"/>
                <form:errors class="text-danger" path="lastName"/>
            </div>
            <div class="mb-3 col-4">
                <form:label path="dorm" class="form-label">Select Dorm:</form:label>
                <form:select path="dorm" class="form-select">
					<c:forEach var="dorm" items="${allDorms}">
						<form:option value="${dorm.id}"><c:out value="${dorm.name}"/></form:option>
					</c:forEach>
				</form:select>
            </div>
            <button class="btn btn-primary mt-3 ">Add</button>
        </form:form>
	</div>
</body>
</html>