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
	<div class="container mt-5">
		<h1 class="display-3">All Burgers</h1>
		<table class="table table-striped table-bordered mb-5">
			<thead>
				<tr>
					<th scope="col">Burger Name</th>
					<th scope="col">Restaurant Name</th>
					<th scope="col">Rating (out of 5)</th>
				</tr>
			</thead>
			<tbody>
				<c:forEach var = "i" items="${allBurgers}">
					<tr>
						<td>${i.burgerName}</td>
						<td>${i.restaurantName}</td>
						<td>${i.rating}</td>
					</tr>
				</c:forEach>
			</tbody>
		</table>
		
		<h1 class="display-3">Add a Burger:</h1>
		<form:form action="/burgers/create" method="post" modelAttribute="burger" class="col-6">
			<div class="mt-3">
				<form:label path="burgerName" class="form-label">Burger Name</form:label>
				<form:input path="burgerName" class="form-control"/>
				<form:errors path="burgerName" class="text-danger"/>
			</div>
			<div class="mt-3">
				<form:label path="restaurantName" class="form-label">Restaurant Name</form:label>
				<form:input path="restaurantName" class="form-control"/>
				<form:errors path="restaurantName" class="text-danger"/>
			</div>
			<div class="mt-3">
				<form:label path="rating" class="form-label">Rating</form:label>
				<form:input type="number" path="rating" class="form-control"/>
				<form:errors path="rating" class="text-danger"/>
			</div>
			<div class="mt-3">
				<form:label path="notes" class="form-label">Notes</form:label>
				<form:textarea path="notes" class="form-control"></form:textarea>
				<form:errors path="notes" class="text-danger"/>
			</div>
			<button class="btn btn-primary btn-lg mt-5 float-end">Submit</button>
		</form:form>
	</div>
</body>
</html>